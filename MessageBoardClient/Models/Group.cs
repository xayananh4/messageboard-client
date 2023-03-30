
using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MessageBoardClient.Models

{
    public class Group
    {
        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public virtual List<Message> Messages { get; set; }

        public static List<Group> GetGroups()
        {
            var apiCallTask = ApiHelper.GetAllGroups();
            var result = apiCallTask.Result;

            JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
            List<Group> groupList = JsonConvert.DeserializeObject<List<Group>>(jsonResponse.ToString());

            return groupList;
        }

        public static Group GetDetails(int id)
        {
            var apiCallTask = ApiHelper.GetGroupID(id);
            var result = apiCallTask.Result;
            // var jsonResponse = JObject.Parse(result);
            // JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
            // JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
            // Group group = JsonConvert.DeserializeObject<Group>(jsonResponse.ToString());
            JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
            List<Group> groupList = JsonConvert.DeserializeObject<List<Group>>(jsonResponse.ToString());

            return groupList[0];
        }
    }
}
