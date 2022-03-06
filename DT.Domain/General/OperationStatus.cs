namespace DT.Domain.General
{
    public class OperationStatus
	{
		public bool Status { get; set; }

		public string Message { get; set; }

		public object Model { get; set; }

		public Exception Exception { get; set; }
	}
}
