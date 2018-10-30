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
    public class SimulationExampleController : Controller {

        [HttpGet]
        public SimulationExample2_reconstructionfound Get() {
            var r = new V4D.Reconstruction.SimulationExample2_reconstructionfound();
            var info = new ReconstructionInfo();
            
            var allLines =
                System.IO.File.ReadAllLines(
                    "eiffel tower.txt");
          

            var all = allLines.Select(x => new V4D.Reconstruction.ContentInfo() {SourceId = x});

            var reconstruction1 = allLines.PickRandom(240)
                .Select(x => new V4D.Reconstruction.ContentInfo() {SourceId = x});

            //var reconstruction2 = allLines.PickRandom(12).Select(x => new V4D.Reconstruction.ContentInfo() {SourceId = x});

            info.UsedContent.AddRange(reconstruction1);
            info.InputContent.AddRange(all);

            info.ReconstructionId = new UUID {Id = "<reconstruction id>"};
            info.ReconstructionGroupId = new UUID {Id = "<reconstruction group id>"};
            info.VisualAnalysisTags.Add("Tower");

            r.Reconstructions.Add(info);
            //var t = Task.FromResult(r);
            return r;
        }
    }
}