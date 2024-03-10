using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using TeachingWebSite.Contracts;
using TeachingWebSite.Models;
using TeachingWebSite.Shared.Configs;

namespace TeachingWebSite.Controllers.V1;


public class TeacherController : BaseController
{
    private readonly ITeacherBusiness _teacherBusiness;
    private readonly IMapper _mapper;
    private readonly MySettings _mySettings;

    public TeacherController(ITeacherBusiness teacherBusiness, IMapper mapper, IOptionsSnapshot<MySettings> mySettings)
    {
        _mapper = mapper;
        _mySettings = mySettings.Value;
        _teacherBusiness = teacherBusiness;
    }

    [Route("{id}")]
    [HttpGet]
    public async Task<IActionResult> Get([FromRoute] int id)
    {
        Teacher teacher = _teacherBusiness.GetTeacherById(id: id);
        if (teacher is null)
        {
            return NotFound();
        }
        teacher.TeacherName.FirstName = $"{_mySettings.StringSetting} {teacher.TeacherName.FirstName}";
        //var teachetDto = _mapper.Map<>();
        return Ok();
    }
}