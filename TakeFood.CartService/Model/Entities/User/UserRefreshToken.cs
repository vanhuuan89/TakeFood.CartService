﻿using CartService.Model.Entities;
using MongoDB.Bson.Serialization.Attributes;

namespace CartService.Model.Entities.User;

public class UserRefreshToken : ModelMongoDB
{
    /// <summary>
    /// Refresh Token's Name
    /// </summary>
    [BsonElement("token")]
    public string Token { get; set; }

    /// <summary>
    /// User refresh token id
    /// </summary>
    [BsonElement("userId")]
    public string UserId { get; set; }
}
