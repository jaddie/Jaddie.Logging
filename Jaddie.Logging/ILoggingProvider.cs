using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jaddie.Logging
{
	public interface ILoggingProvider
	{
		void LogValue(SeverityLevel level, object value, object owner, Exception ex = null);
		void LogValue(SeverityLevel level, object owner, Exception ex = null, params object[] values);
		void LogValue(SeverityLevel level, object owner, params object[] values);

		void Debug(object objectToLog, object owner = null);
		void Debug(object objectToLog, Type ownerType);

		void Error(object objectToLog, object owner = null, Exception exception = null);
		void Error(object objectToLog, Type ownerType, Exception exception = null);

		void Fatal(object objectToLog, object owner = null, Exception exception = null);
		void Fatal(object objectToLog, Type ownerType, Exception exception = null);

		void Info(object objectToLog, object owner = null);
		void Info(object objectToLog, Type ownerType);

		void Warn(object objectToLog, object owner = null, Exception exception = null);
		void Warn(object objectToLog, Type ownerType, Exception exception = null);
	}
}
