
namespace ConnectTelegramBot.BotReceive
{
    public class UpdateHandler
    {
      public static async Task updateHandler(ITelegramBotClient Bot, Update up, CancellationToken arg3)
        {
            //
          Task<User>? getMe= Bot.GetMeAsync();
          long? chatId= up.Message.Chat.Id;
            long? userId = up.Message.From.Id;
            string? userName = up.Message.From.Username;



           await Task.CompletedTask;
        }
    }
}
