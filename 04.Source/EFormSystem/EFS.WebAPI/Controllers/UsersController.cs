using EFS.APIModel.Users;
using EFS.BusinessLogic.Users;
using EFS.Common.Encryption;
using EFS.Model.Users;
using EFS.WebAPI.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFS.WebAPI.Controllers
{
    /// <summary>
    /// The users controller.
    /// </summary>
    [TokenValidationAttribute]
    public class UsersController : BaseController
    {
        /// <summary>
        /// The _encryption service.
        /// </summary>
        private readonly IEncryptionService _encryptionService;

        /// <summary>
        /// The _user data mapper.
        /// </summary>
        private readonly IUserBL _userBL;

        /// <summary>
        /// Initializes a new instance of the <see cref="UsersController"/> class.
        /// </summary>
        /// <param name="userDataMapper">
        /// The user repository.
        /// </param>
        /// <param name="mapper">
        /// The mapper.
        /// </param>
        /// <param name="encryptionService">
        /// The encryption service.
        /// </param>
        public UsersController(
            IUserBL userBL,
            IEncryptionService encryptionService)
        {
            _userBL = userBL;
            _encryptionService = encryptionService;
        }

        /// <summary>
        /// Gets all users.
        /// </summary>
        /// <returns>
        /// The <see cref="IEnumerable"/>.
        /// </returns>
        /// <remarks>
        /// GET user
        /// </remarks>
        public IEnumerable<UserItem> Get()
        {
            var users = new List<UserItem>(new UserItem[] { new UserItem() { ID = Guid.NewGuid(), Username = "asdf" } });
            return users;
        }
    }
}
