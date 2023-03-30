using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MessageBoardClient.Models{

public class Message
{
    public int MessageId { get; set; }
    [ForeignKey("Group")]
    public int GroupId { get; set; }

    public string MessageText { get; set; }
    public DateTime PostDate { get; set; }
    public string UserName { get; set; }

    public static List<Message> GetMessages()
    {
        var apiCallTask = ApiHelper.GetAllMessages();
        var result = apiCallTask.Result;

        JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
        List<Message> messageList = JsonConvert.DeserializeObject<List<Message>>(jsonResponse.ToString());

        return messageList;
    }
}


}

