namespace Assets.InnerNet
{
    public class LinkStatusResponse : System.Object
    {
        public Assets.InnerNet.LinkStatusResponse.LinkStatus Status;
        public Assets.InnerNet.PinRequestError[] Errors;
        public enum LinkStatus : int
        {
            Pending = 0,
            Success = 1,
            Error = 2,
}
    }
}
