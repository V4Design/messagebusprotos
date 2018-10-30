using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using V4D.Reconstruction;

namespace v4demo_simulation_rest.Controllers
{
    [Produces("text/proto3")]
    [Route("api/[controller]")]
    [ApiController]
    public class SimulationExample_reconstructionTagUpdateController : ControllerBase
    {
        [HttpGet]
        public SimulationExample2_reconstructionTagUpdate get() {
            var r = new SimulationExample2_reconstructionTagUpdate() {
                ReconstructionId = new UUID() {Id = "<reconstruction id>"}
            };
            r.VisualAnalysisTags.AddRange(new[] {"Tower", "Trees", "Building"});

            return r;
        }
    }
}