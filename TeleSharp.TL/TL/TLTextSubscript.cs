using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	[TLObject(-311786236)]
    public class TLTextSubscript : TLAbsRichText
    {
        public override int Constructor
        {
            get
            {
                return -311786236;
            }
        }

             public TLAbsRichText Text {get;set;}


		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            Text = (TLAbsRichText)ObjectUtils.DeserializeObject(br);

        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            ObjectUtils.SerializeObject(Text,bw);

        }
    }
}