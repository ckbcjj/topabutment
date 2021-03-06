using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// TradeGetResponse.
    /// </summary>
    public class TradeGetResponse : TopResponse
    {
        /// <summary>
        /// 搜索到的交易信息列表，返回的Trade和Order中包含的具体信息为入参fields请求的字段信息
        /// </summary>
        [XmlElement("trade")]
        public Top.Api.Domain.Trade Trade { get; set; }

    }
}
