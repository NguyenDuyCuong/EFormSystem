using EFS.APIModel.Users;
using EFS.BusinessLogic.Users;
using EFS.Common.Encryption;
using EFS.Model.Users;
using EFS.WebAPI.Filters;
using Microsoft.AspNetCore.Mvc;
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
        [HttpGet]
        public IEnumerable<UserItem> Get()
        {
            var users = _userBL.FindAll();
            return users;
        }

        /// <summary>
        /// Gets a user by id
        /// </summary>
        /// <param name="id">
        /// The id.
        /// </param>
        /// <returns>
        /// The <see cref="GetUser"/>.
        /// </returns>
        /// <exception cref="NotFoundException">
        /// Thrown for invalid user id.
        /// </exception>
        /// <remarks>
        /// GET users/B5608F8E-F449-E211-BB40-1040F3A7A3B1
        /// </remarks>
        public GetUser Get(Guid id)
        {
            var user = _userBL.FindById(id);

            if (user == null)
            {
                throw new NotFoundException();
            }

            return _mapper.Map<User, GetUser>(user);
        }

        /// <summary>
        /// The post.
        /// </summary>
        /// <param name="item">
        /// The item.
        /// </param>
        /// <returns>
        /// The <see cref="HttpResponseMessage"/>.
        /// </returns>
        /// <remarks>
        /// POST users
        /// </remarks>
        [HttpPost]
        public HttpResponseMessage Post(PostUser item)
        {
            var user = new User()
            {
                Username = item.Username,
                Password = EncryptedString.Create(item.Password, _encryptionService)
            };

            if (user.IsValid)
            {
                _userBL.Insert(user);

                GetUser createdItem = _mapper.Map<User, GetUser>(user);
                return CreatedHttpResponse(createdItem.ID, createdItem);
            }

            return Request.CreateResponse(HttpStatusCode.BadRequest, user.ValidationErrors);
        }

        /// <summary>
        /// The put.
        /// </summary>
        /// <param name="id">
        /// The id.
        /// </param>
        /// <param name="item">
        /// The item.
        /// </param>
        /// <returns>
        /// The <see cref="HttpResponseMessage"/>.
        /// </returns>
        /// <exception cref="NotFoundException">
        /// Thrown for invalid user id.
        /// </exception>
        /// <remarks>
        /// PUT users/B5608F8E-F449-E211-BB40-1040F3A7A3B1
        /// </remarks>
        [HttpPut]
        public HttpResponseMessage Put(Guid id, PutUser item)
        {
            User user = _userBL.FindById(id);

            if (user == null)
            {
                throw new NotFoundException();
            }

            user.Username = item.Username;

            if (user.IsValid)
            {
                _userBL.Update(user);
                return Request.CreateResponse(HttpStatusCode.OK);
            }

            return Request.CreateResponse(HttpStatusCode.BadRequest, user.ValidationErrors);
        }

        /// <summary>
        /// The delete.
        /// </summary>
        /// <param name="id">
        /// The id.
        /// </param>
        /// <returns>
        /// The <see cref="HttpResponseMessage"/>.
        /// </returns>
        /// <remarks>
        /// DELETE users/B5608F8E-F449-E211-BB40-1040F3A7A3B1
        /// </remarks>
        [HttpDelete]
        public HttpResponseMessage Delete(Guid id)
        {
            _userBL.Delete(id);
            return new HttpResponseMessage(HttpStatusCode.NoContent);
        }
    }
}
