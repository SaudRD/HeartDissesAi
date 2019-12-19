using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RestSharp;
using Newtonsoft.Json.Linq;

namespace heartV2
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lbPredict_Click(object sender, EventArgs e)
        {


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var client = new RestClient("API");
            var request = new RestRequest(Method.POST);
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("Connection", "keep-alive");
            request.AddHeader("Content-Length", "630");
            request.AddHeader("Accept-Encoding", "gzip, deflate");
            request.AddHeader("Host", "ussouthcentral.services.azureml.net");
            request.AddHeader("Postman-Token", "4872f5d0-45bc-4f1c-8620-aa8f76e2a181,ba40f45b-c827-473c-b883-c52000a8fa0e");
            request.AddHeader("Cache-Control", "no-cache");
            request.AddHeader("Accept", "*/*");
            request.AddHeader("User-Agent", "PostmanRuntime/7.19.0");
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Authorization", "FROM POSTMAN API");
            request.AddParameter("undefined", "{\r\n  \"Inputs\": {\r\n    \"input1\": {\r\n      \"ColumnNames\": [\r\n        \"age\",\r\n        \"sex\",\r\n        \"cp\",\r\n        \"trestbps\",\r\n        \"chol\",\r\n        \"fbs\",\r\n        \"restecg\",\r\n        \"thalach\",\r\n        \"exang\",\r\n        \"oldpeak\",\r\n        \"slope\",\r\n        \"ca\",\r\n        \"thal\",\r\n        \"result\"\r\n      ],\r\n      \"Values\": [\r\n        [\r\n          \"" + txtAge.Text + "\",\r\n          \"" + rbSex.SelectedItem.Value + "\",\r\n          \"" + txtcp.Text + "\",\r\n          \"" + txtTrestpbs.Text + "\",\r\n          \"" + txtCHOL.Text + "\",\r\n          \"" + txtFBS.Text + "\",\r\n          \"" + txtRestecg.Text + "\",\r\n          \"" + txtThalach.Text + "\",\r\n          \"" + txtExang.Text + "\",\r\n          \"" + txtOldpeak.Text + "\",\r\n          \"" + txtSlope.Text + "\",\r\n          \"" + txtCA.Text + "\",\r\n          \"" + txtThal.Text + "\",\r\n          \"0\"\r\n        ]\r\n      ]\r\n    }\r\n  },\r\n  \"GlobalParameters\": {}\r\n}", ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            //lblResult.Text = response.Content.ToString();

             var result = JObject.Parse(response.Content);
             string predction = result["Results"]["output1"]["value"]["Values"].ToString();
            predction = predction.Replace("[", "").Replace("]","").Replace("\"","");

            lblResult.Text = Convert.ToDecimal(predction).ToString("#0.##%");
        }
    }
}