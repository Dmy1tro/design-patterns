namespace Patterns.Builder
{
    internal class ButtonBuilderV2
    {
        // It could be an object that contains all aplied changes
        private readonly List<Action<Button>> _actionsToApply = new();

        // Entry point
        public static ButtonBuilderV2 CreateBuilder()
        {
            return new ButtonBuilderV2();
        }

        public ButtonBuilderV2 WithText(string text)
        {
            // Here can be validation or pre-processing of value before setting it to the object
            _actionsToApply.Add(button =>
            {
                button.Text = text;
            });

            return this;
        }

        public ButtonBuilderV2 WithColor(string color)
        {
            _actionsToApply.Add(button =>
            {
                button.Color = color;
            });

            return this;
        }

        // In this version Builder and 'Build' method can be reused many times as 'Build' returns a new object each time
        public Button Build()
        {
            var button = new Button();

            _actionsToApply.ForEach(action => action.Invoke(button));

            return button;
        }

        public void Example()
        {
            var sendButtonbuilder = ButtonBuilderV2
                .CreateBuilder()
                .WithText("Send");

            var sendButton1 = sendButtonbuilder.Build();
            var sendButton2 = sendButtonbuilder.Build();

            var redSendButtonBuilder = sendButtonbuilder.WithColor("red");

            var redSendButton1 = redSendButtonBuilder.Build();
            var redSendButton2 = redSendButtonBuilder.Build();
        }
    }
}
