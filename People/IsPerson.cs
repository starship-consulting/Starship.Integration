using System;

namespace Starship.Integration.People {

    public interface IsPerson {
        
        string FirstName { get; set; }

        string LastName { get; set; }

        string Email { get; set; }
    }
}