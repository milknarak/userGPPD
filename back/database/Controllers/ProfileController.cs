using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace database.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfileController : ControllerBase
    {

        [HttpGet("Dataprofile")]
        public IActionResult profile()
        {

            var context = new Context();
            var profile = context.profile.ToList();
            return Ok(profile);
            //return Ok(new { Name = "Chayutra",
            //    Lastname = "Chantachote",
            //    Nickname = "Milk",
            //    Birth = "08 April, 1998",
            //    Age = "23",
            //    Email = "chayutra.cyt22@gmail.com",
            //    Tel = "861500901",
            //    LineID = "Chayutra22",
            //    University = "Kasetsart University",
            //    Faculty = "Social Science",
            //    Department = "Psychology",
            //    GPA = "3.04",
            //    Hobby = "play game",
            //    Dateworkfirst = "May, 2021 - March 2022",
            //    Placeworkfirst = "Crepe Dekuan Chanthaburi",
            //    positionfirst = "Business owner",
            //    work = "seller, check stock and Prepare suppile",
            //    Dateworksecond = "March, 2022 - present",
            //    Placeworksecond = "Soft square 1999 CO.,LTD.",
            //    positionsecond = "software Developer",
            //    Hardskill1 = "Ms office (word, excel, powerpoint)",
            //    Hardskill2 = "Photoshop",
            //    Softskill1 = "Creative thinking",
            //    softskill2 = "Team work",
            //    softskill3 = "Emotion control",
            //    softskill4 = "Adaptability",
            //    motto = "A little girl who has motto that work hard, play harder, eat hardest.",
            //    Thai = "Native",
            //    English = "Intermediate",
            //    liveplace = "Chanthaburi, Thailand "
            //});
        }


    }
}
