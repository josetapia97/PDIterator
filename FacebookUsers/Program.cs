using FacebookUsers.Elements;

List<User> usuarios = new List<User>()
{
    new User{name = "Alice" },
    new User{name = "Pedro"},
    new User{name = "Mark"},
    new User{name = "Elon"},
    new User{name = "Marco"}
};

UserCollection ColeccionNueva = new UserCollection(usuarios);
Client client = new Client();
client.ShowUsers(ColeccionNueva);