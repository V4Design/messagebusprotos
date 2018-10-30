using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using V4D.Reconstruction;
using V4Design.Protos.Taln;

namespace v4demo_simulation_rest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TALN_oneofController : ControllerBase
    {

        [HttpGet]
        public AnalysisResult Get() {
            var r = new AnalysisResult();
            r.Text = "some text";
            r.Concepts.Add(new Concept() {
                BabelNetInfo = new BabelNetConceptInfo() {
                    Confidence = 5,
                    Description = "TESTDESCRIPTION",
                    Id = "efonzsefnose"
                },
                Begin = 2,
                DBpediaInfo = new DBpediaConceptInfo() {
                    SimpleTypes = "simple"
                }
            });
            return r;
        }
    }
}