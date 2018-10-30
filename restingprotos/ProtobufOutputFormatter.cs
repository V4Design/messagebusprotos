using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Protobuf;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.Extensions.Logging;
using Microsoft.Net.Http.Headers;

namespace v4demo_simulation_rest
{
    public class ProtobufOutputFormatter : TextOutputFormatter {
        public ProtobufOutputFormatter() {
            SupportedMediaTypes.Add(MediaTypeHeaderValue.Parse("text/proto3"));

            SupportedEncodings.Add(Encoding.UTF8);
            SupportedEncodings.Add(Encoding.Unicode);
        }

        public override Task WriteResponseBodyAsync(OutputFormatterWriteContext context, Encoding selectedEncoding) {
            IServiceProvider serviceProvider = context.HttpContext.RequestServices;
            var logger = serviceProvider.GetService(typeof(ILogger<ProtobufOutputFormatter>)) as ILogger;

            var response = context.HttpContext.Response;

            var buffer = new StringBuilder();
            if (context.Object is IEnumerable<IMessage>) {
                foreach (IMessage msg in context.Object as IEnumerable<IMessage>) {
                    FormatVcard(buffer, msg, logger);
                }
            }
            else {
                var msg = context.Object as IMessage;
                FormatVcard(buffer, msg, logger);
            }
            return response.WriteAsync(buffer.ToString());
        }

        private static void FormatVcard(StringBuilder buffer, IMessage msg, ILogger logger) {
            buffer.Append(Google.Protobuf.JsonFormatter.Default.Format(msg));
            //logger.LogInformation($"Writing {contact.FirstName} {contact.LastName}");
        }

        // Todo: type Task<IMessage> Task<IEnumerable<IMessage>>
        protected override bool CanWriteType(Type type) {
            if (typeof(IMessage).IsAssignableFrom(type)
                || typeof(IEnumerable<IMessage>).IsAssignableFrom(type)) {
                return base.CanWriteType(type);
            }
            return false;
        }
    }
}
