using Library.API.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.API.Controllers
{
    /// <summary>
    /// Root document to make API discoverable
    /// </summary>
    [Route("api")]
    public class RootController : Controller
    {
        private IUrlHelper _urlHelper;

        public RootController(IUrlHelper urlHelper)
        {
            _urlHelper = urlHelper;
        }

        [HttpGet(Name = "GetRoot")]
        public IActionResult GetRoot([FromHeader(Name = "Accept")] string mediaType)
        {
            if (mediaType == "application/vnd.marvin.hateoas+json")
            {
                var links = new List<LinkDto>
                {
                    new LinkDto(_urlHelper.Link("GetRoot", new { }),
                        "self",
                        "GET"),
                    new LinkDto(_urlHelper.Link("GetAuthors", new { }),
                        "authors",
                        "GET"),
                    new LinkDto(_urlHelper.Link("CreateAuthor", new { }),
                        "create_author",
                        "POST")
                };

                return Ok(links);
            }

            return NoContent();
        }
    }
}
