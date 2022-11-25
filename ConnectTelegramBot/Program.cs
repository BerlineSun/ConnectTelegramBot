
ReceiverOptions? receiverOptions = new ReceiverOptions()
{
    AllowedUpdates = new UpdateType[]
              {
                    UpdateType.Message,
                    UpdateType.EditedMessage,
                    UpdateType.CallbackQuery,
                    UpdateType.ChannelPost,
                    UpdateType.ChatMember,
                    UpdateType.MyChatMember,
              }
};

_Client.ReceiveAsync(UpdateHandler.updateHandler,ErrorHandler.errorHandler, receiverOptions).Wait();





