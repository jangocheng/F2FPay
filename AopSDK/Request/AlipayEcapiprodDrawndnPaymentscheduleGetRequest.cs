using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.ecapiprod.drawndn.paymentschedule.get
    /// </summary>
    public class AlipayEcapiprodDrawndnPaymentscheduleGetRequest : IAopRequest<AlipayEcapiprodDrawndnPaymentscheduleGetResponse>
    {
        /// <summary>
        /// 支用编号
        /// </summary>
        public string DrawndnNo { get; set; }

        /// <summary>
        /// 身份证
        /// </summary>
        public string EntityCode { get; set; }

        /// <summary>
        /// 客户姓名
        /// </summary>
        public string EntityName { get; set; }

        /// <summary>
        /// 融资平台分配给ISV的编码
        /// </summary>
        public string IsvCode { get; set; }

        /// <summary>
        /// 融资平台分配给小贷公司的机构编码
        /// </summary>
        public string OrgCode { get; set; }

        #region IAopRequest Members
        private string apiVersion = "1.0";
		private string terminalType;
		private string terminalInfo;
        private string prodCode;
		private string notifyUrl;

		public void SetNotifyUrl(string notifyUrl){
            this.notifyUrl = notifyUrl;
        }

        public string GetNotifyUrl(){
            return this.notifyUrl;
        }

        public void SetTerminalType(String terminalType){
			this.terminalType=terminalType;
		}

    	public string GetTerminalType(){
    		return this.terminalType;
    	}

    	public void SetTerminalInfo(String terminalInfo){
    		this.terminalInfo=terminalInfo;
    	}

    	public string GetTerminalInfo(){
    		return this.terminalInfo;
    	}

        public void SetProdCode(String prodCode){
            this.prodCode=prodCode;
        }

        public string GetProdCode(){
            return this.prodCode;
        }

        public string GetApiName()
        {
            return "alipay.ecapiprod.drawndn.paymentschedule.get";
        }

        public void SetApiVersion(string apiVersion){
            this.apiVersion=apiVersion;
        }

        public string GetApiVersion(){
            return this.apiVersion;
        }

        public IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("drawndn_no", this.DrawndnNo);
            parameters.Add("entity_code", this.EntityCode);
            parameters.Add("entity_name", this.EntityName);
            parameters.Add("isv_code", this.IsvCode);
            parameters.Add("org_code", this.OrgCode);
            return parameters;
        }

        #endregion
    }
}
