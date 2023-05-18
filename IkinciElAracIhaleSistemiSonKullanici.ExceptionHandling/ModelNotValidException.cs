using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IkinciElAracIhaleSistemiSonKullanici.ExceptionHandling
{
    public class ModelNotValidException : ExceptionBase
	{
		public List<string> ValidationMessages { get; }
		public ModelNotValidException(List<string> validateinmessages)
		{
			ValidationMessages = validateinmessages;
		}

		public ModelNotValidException(List<string> validateinmessages, string msg) : base(msg)
		{
			ValidationMessages = validateinmessages;
		}

		public ModelNotValidException(List<string> validateinmessages, string msg, Exception inner) : base(msg, inner)
		{
			ValidationMessages = validateinmessages;
		}



	}
}
