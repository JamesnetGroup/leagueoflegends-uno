using Jamesnet.Core;
using Leagueoflegends.Support.Local.Models;
namespace Leagueoflegends.Social.Local.ViewModels;

public class SocialContentViewModel : ViewModelBase, IViewLoadable
{
    private readonly IFriendsLoader _friendsLoader;
    private List<FriendCategory> _friends;

    public List<FriendCategory> Friends
    {
        get => _friends;
        set => SetProperty(ref _friends, value);
    }

    public SocialContentViewModel(IFriendsLoader friendsLoader)
    {
        _friendsLoader = friendsLoader;
        LoadFriends();
    }

    public void Loaded()
    {
    }

    private void LoadFriends()
    {
        Friends = _friendsLoader.LoadFriends();
    }
}
