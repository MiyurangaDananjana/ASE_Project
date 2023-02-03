using Fuelling_Tracking_WEB_API.DAL;
using Fuelling_Tracking_WEB_API.Models;
using System;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace Fuelling_Tracking_WEB_API.BLL
{
    public class VehicalTypeBLL
    {
      

        internal static VehicalTypeListDAO GetVehicalTypeAndId()
        {
           VehicalTypeListDAO dto = new VehicalTypeListDAO();
            dto.VehicalTypesList = CustomerDAL.Get_Vehical_Detail();
            return (dto);
        }

        internal static VehicalTypeListDAO Get_Fuel_Station()
        {
            VehicalTypeListDAO dto = new VehicalTypeListDAO();
            dto.fuelStations = CustomerDAL.Get_FuelStation_Detail();
            return (dto);
        }

        internal static void Save_Customer(CustomerDetail dto)
        {
            CustomerDAL.Save_Customer(dto);
        }

        internal static void UpdateOtpSendDateTime(CustomerDetail cussetail)
        {
            CustomerDAL.UpdateOtpSendDateTime(cussetail);
        }

        public void messageSend(string customerPhoneNumber, string systemMassage)
        {
           
          
            var sid = "AC5d79933c372f28d2a00a56a1a0210e88";
            var varAuthToken = "9887ebc15f79822f7d70a7341565ae50";
            TwilioClient.Init(sid, varAuthToken);

            MessageResource.Create(
                to: new PhoneNumber(customerPhoneNumber),
                from: new PhoneNumber("+15752215853"),
                body: systemMassage);

        }

        
    }
}
