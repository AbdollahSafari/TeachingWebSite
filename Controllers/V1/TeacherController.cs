using AutoMapper;
using Microsoft.Extensions.Options;
using TeachingWebSite.Contracts;
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
}