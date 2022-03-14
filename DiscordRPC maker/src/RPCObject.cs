using System;
using DiscordRPC;

namespace DiscordRPC_maker.src
{
    public class RPCObject
    {
        public String rpcName;
        public String clientId;
        public String details;
        public String state;
        public String largeImageKey;
        public String largeImageText;
        public String smallImageKey;
        public String smallImageText;

        public bool timestamps;

        public bool button1;
        public String button1Text;
        public String button1Link;
        public bool button2;
        public String button2Text;
        public String button2Link;

        public DiscordRpcClient client;

        public RPCObject() { }

        public RPCObject(
            String rpcName,
            String clientId,
            String details = "",
            String state = "",
            String largeImageKey = "",
            String largeImageText = "",
            String smallImageKey = "",
            String smallImageText = "",
            bool timestamps = false,
            bool button1 = false,
            String button1Text = "",
            String button1Link = "",
            bool button2 = false,
            String button2Text = "",
            String button2Link = ""
        )
        {
            this.rpcName = rpcName;
            this.clientId = clientId;
            this.details = details;
            this.state = state;
            this.largeImageKey = largeImageKey;
            this.largeImageText = largeImageText;
            this.smallImageKey = smallImageKey;
            this.smallImageText = smallImageText;

            this.timestamps = timestamps;

            this.button1 = button1;
            this.button1Text = button1Text;
            this.button1Link = button1Link;
            this.button2 = button2;
            this.button2Text = button2Text;
            this.button2Link = button2Link;
        }

        // Init the rpc
        public bool Init()
        {
            this.client = new DiscordRpcClient(this.clientId);
            return this.client.Initialize();
        }

        private Button[] InitButtons()
        {
            Button[] buttons = null;

            if (this.button1 && this.button2)
            {
                buttons = new Button[2];
                buttons[0] = new Button() { Label = this.button1Text, Url = this.button1Link };
                buttons[1] = new Button() { Label = this.button2Text, Url = this.button2Link };
            }
            else if (this.button1 && !this.button2)
            {
                buttons = new Button[1];
                buttons[0] = new Button() { Label = this.button1Text, Url = this.button1Link };
            }
            else if (!this.button1 && this.button2)
            {
                buttons = new Button[1];
                buttons[0] = new Button() { Label = this.button2Text, Url = this.button2Link };
            }

            return buttons;
        }

        private Timestamps InitTimestamps()
        {
            if (this.timestamps)
                return Timestamps.Now;
            return null;
        }

        // Create a new rpc
        public void InitRPC()
        {

            Button[] buttons = InitButtons();
            Timestamps ts = InitTimestamps();

            this.client.SetPresence(new RichPresence()
            {
                Details = this.details,
                State = this.state,
                Assets = new Assets()
                {
                    LargeImageKey = this.largeImageKey,
                    LargeImageText = this.largeImageText,
                    SmallImageKey = this.smallImageKey,
                    SmallImageText = this.smallImageText
                },
                Buttons = buttons,
                Timestamps = ts
            });
        }

        public void Update()
        {

        }

        // Deinit the rpc
        public void Deinitialize()
        {
            if (client != null)
            {
                try
                {
                    this.client.Deinitialize();
                }
                catch (Exception) { }
                this.client.Dispose();
            }
        }
    }
}
