namespace Nacos.V2.Remote
{
    public abstract class CommonResponse
    {
        [Newtonsoft.Json.JsonProperty("resultCode")]
        public int ResultCode { get; set; } = 200;

        [Newtonsoft.Json.JsonProperty("errorCode")]
        public int ErrorCode { get; set; }

        [Newtonsoft.Json.JsonProperty("message")]
        public string Message { get; set; }

        [Newtonsoft.Json.JsonProperty("requestId")]
        public string RequestId { get; set; }

        public bool IsSuccess() => ResultCode == 200;

        public abstract string GetRemoteType();
    }
}
