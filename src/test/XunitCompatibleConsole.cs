using System.Collections.Generic;
using System.IO;
using System.Text;
using interpreter;
using Xunit.Abstractions;
using static interpreter.IConsole;

namespace test
{
    public class TestConsole : TextWriter, IConsole
    {
        private readonly IDictionary<Channel,StringBuilder> content = 
            new Dictionary<Channel, StringBuilder>() {[Channel.Standard]=new StringBuilder(),[Channel.Error]=new StringBuilder()};

        private readonly ITestOutputHelper helper;
        public override Encoding Encoding => Encoding.Default;

        public TestConsole(ITestOutputHelper helper)
        {
            this.helper = helper;
        }

        public string Content => content[Channel.Standard].ToString();
        public string ErrorContent => content[Channel.Error].ToString();
        
        public override string ToString()
        {
            return content.ToString();
        }

        public override void Write(string text)
        {
            Write(text,Channel.Standard);
        }
        
        public override void WriteLine(string text)
        {
            WriteLine(text,Channel.Standard);
        }

        public void Write(string text, Channel channel)
        {
            helper.WriteLine(text.ToString());
            content[channel].Append(text);

        }

        public void WriteLine(string text, Channel channel)
        {
            Write(text.ToString()+"\n",channel);
        }
    }
}