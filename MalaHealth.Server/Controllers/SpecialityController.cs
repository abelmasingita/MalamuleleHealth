using AutoMapper;
using MalaHealth.Application.Repository.IRepository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MalaHealth.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class SpecialityController : ControllerBase
    {
        //private readonly IUnitofWork unitofWork;
        //private readonly IMapper mapper;
        //public SpecialityController(IUnitofWork unitofWork,IMapper mapper)
        //{
        //    this.unitofWork = unitofWork;
        //    this.mapper = mapper;
        //}

        //[HttpGet("GetSpecialities")]
        //[ProducesResponseType(200, Type = typeof(IEnumerable<SpecialtyDto>))]
        //[ProducesResponseType(400, Type = typeof(IEnumerable<SpecialtyDto>))]
        //[ProducesResponseType(404, Type = typeof(IEnumerable<SpecialtyDto>))]
        //[Authorize(Roles = "Administrator, Doctor, Nurse, Pharmacist, LabTechnician, Patient")]
        //public async Task<IActionResult> GetSpecialities()
        //{
        //    try
        //    {
        //        var specialties = unitofWork.Speciality.GetList().GetAwaiter().GetResult();
        //        var mapped = mapper.Map<SpecialtyDto>(specialties);

        //        return Ok(mapped);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.ToString());
        //    }

        //}


        ////    [HttpGet("GetWard")]
        ////    [ProducesResponseType(200, Type = typeof(WardDto))]
        ////    [ProducesResponseType(400, Type = typeof(WardDto))]
        ////    [ProducesResponseType(404, Type = typeof(WardDto))]
        ////    [Authorize(Roles = "Administrator, Doctor, Nurse, Pharmacist, LabTechnician")]
        ////    public async Task<IActionResult> GetWard(Guid wardId)
        ////    {

        ////        try
        ////        {
        ////            var ward = unitofWork.Ward.Get(d => d.Id == wardId).GetAwaiter().GetResult();
        ////            if (ward == null)
        ////            {
        ////                return NotFound();
        ////            }

        ////            var mapped = mapper.Map<WardDto>(ward);

        ////            return Ok(mapped);
        ////        }
        ////        catch (Exception ex)
        ////        {
        ////            throw new Exception(ex.ToString());
        ////        }

        ////    }

        ////    [HttpPost("AddWard")]
        ////    [ProducesResponseType(200, Type = typeof(WardDto))]
        ////    [ProducesResponseType(204, Type = typeof(WardDto))]
        ////    [ProducesResponseType(400, Type = typeof(WardDto))]
        ////    [Authorize(Roles = "Administrator")]
        ////    public async Task<IActionResult> AddWard([FromBody] AddWardDto ward)
        ////    {

        ////        try
        ////        {
        ////            if (ward == null)
        ////            {
        ////                return BadRequest();
        ////            }

        ////            if (!ModelState.IsValid)
        ////            {
        ////                return BadRequest(ModelState);
        ////            }

        ////            var mapped = mapper.Map<Ward>(ward);
        ////            unitofWork.Ward.Add(mapped);
        ////            unitofWork.Save();

        ////            return Ok(mapped);
        ////        }
        ////        catch (Exception ex)
        ////        {
        ////            throw new Exception(ex.ToString());
        ////        }

        ////    }


        ////    [HttpPut("UpdateWard")]
        ////    [ProducesResponseType(200, Type = typeof(Ward))]
        ////    [ProducesResponseType(400, Type = typeof(Ward))]
        ////    [Authorize(Roles = "Administrator")]
        ////    public async Task<IActionResult> UpdateWard(Guid wardId,[FromBody] Ward ward)
        ////    {

        ////        try
        ////        {
        ////            if (ward == null)
        ////            {
        ////                return BadRequest();
        ////            }

        ////            if (!ModelState.IsValid)
        ////            {
        ////                return BadRequest(ModelState);
        ////            }

        ////            if (GetWard(wardId).GetAwaiter().GetResult() != null)
        ////            {
        ////                unitofWork.Ward.Update(ward);
        ////                unitofWork.Save();
        ////            }
        ////            else
        ////            {
        ////                return NotFound();
        ////            }

        ////            return NoContent();
        ////        }
        ////        catch (Exception ex)
        ////        {
        ////            throw new Exception(ex.ToString());
        ////        }
        ////    }


        ////    [HttpDelete("RemoveWard")]
        ////    [ProducesResponseType(204)]
        ////    [ProducesResponseType(400)]
        ////    [ProducesResponseType(404)]
        ////    public IActionResult RemoveWard(Guid wardId)
        ////    {
        ////        var ward = unitofWork.Ward.Get(d => d.Id == wardId).GetAwaiter().GetResult();
        ////        if (ward == null)
        ////        {
        ////            return NotFound();
        ////        }

        ////        unitofWork.Ward.Remove(ward);
        ////        unitofWork.Save();
        ////        return NoContent();
        ////    }
    }
}
