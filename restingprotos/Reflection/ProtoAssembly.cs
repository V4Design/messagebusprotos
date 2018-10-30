using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Google.Protobuf;
using Microsoft.EntityFrameworkCore.Query;

namespace v4demo_simulation_rest.Reflection
{
    /// <summary>
    /// Scan (current) assembly for proto interfaces: IMessage implementations
    ///  & GRPC: find all static readonly grpc::Method<in,out>
    /// 
    /// OPTIONS for handling proto files:
    ///  - Generate cs
    ///  - runtime compilation
    /// 
    /// First = dynamic controller generation
    /// </summary>
    public class ProtoAssembly {
       
        public static void GenerateCSharpCode() { }
        public void CompileProto() { }
        //public static IMessage[] FetchMessages
    }
}
