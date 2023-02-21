
using System;

namespace LoggerExample
{
    public class Actions
    {
        private readonly Logger logger;

        public Actions()
        {
            logger = Logger.Instance;
        }

        public Result Start()
        {
            logger.Log($"Start method: {nameof(Start)}", LogType.Info);
            return new Result { Status = true };
        }

        public Result SkipLogic()
        {
            logger.Log($"Skipped logic in method: {nameof(SkipLogic)}", LogType.Warning);
            return new Result { Status = true };
        }

        public Result BreakLogic()
        {
            Result result = new Result { Status = false, ErrorMessage = "I broke a logic" };
            logger.Log($"Action failed by a reason: {result.ErrorMessage}", LogType.Error);
            return result;
        }
    }

    public class Result
    {
        public bool Status { get; set; }
        public string ErrorMessage { get; set; }
    }
}