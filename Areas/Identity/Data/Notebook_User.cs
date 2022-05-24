using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Notebook_VS_Final_assignment.Model;

namespace Notebook_VS_Final_assignment.Areas.Identity.Data;

// Add profile data for application users by adding properties to the Notebook_User class
public class Notebook_User : IdentityUser
{
    public List<ThoughtSnippets> Notes { get; set; } = new List<ThoughtSnippets>();
}
