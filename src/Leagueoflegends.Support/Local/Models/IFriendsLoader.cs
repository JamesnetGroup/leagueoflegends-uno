using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leagueoflegends.Support.Local.Models;
public interface IFriendsLoader
{
    List<FriendCategory> LoadFriends();
}
