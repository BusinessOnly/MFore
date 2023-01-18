using Metrafor.Domain.Entries;

namespace Metrafor.Application.Commands.RegisterCommand
{
    public partial class RegisterCommand
    {
        public async Task<Result> ExecuteAsync(Request request)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(request.Login))
                    return new Result { DisplayMessage = "Не указан логин" };

                if (string.IsNullOrWhiteSpace(request.Password))
                    return new Result { DisplayMessage = "Не указан пароль" };

                var user = await _userRepository.FindByLoginAsync(request.Login);
                if (user != null)
                    return new Result { DisplayMessage = "Пользователь с таким логиным уже существует" };

                user = new User(request.Login, request.Password);
                await _userRepository.SaveAsync(user);

                return new Result { Success = true, UserId = user.UserId };
            }
            catch (Exception ex)
            {
                return new Result { DisplayMessage = ex.Message };
            }
        }
    }
}
