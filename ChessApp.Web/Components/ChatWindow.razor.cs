﻿using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChessApp.Web.Components
{
    public partial class ChatWindow : ComponentBase
    {
        protected List<(DateTime time, string message)> MessagesList { get; private set; }

        public ChatWindow()
        {
            this.MessagesList = new List<(DateTime time, string message)>();
        }

        public void AddMessage(string message, DateTime? time = null)
        {
            this.MessagesList.Add((time ?? DateTime.Now, message));
            this.StateHasChanged();
        }

    }
}
