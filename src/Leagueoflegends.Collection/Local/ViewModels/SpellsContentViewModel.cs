using Jamesnet.Core;
using Leagueoflegends.Support.Local.Datas;
using Leagueoflegends.Support.Local.Models;
using System.Collections.ObjectModel;

namespace Leagueoflegends.Collection.Local.ViewModels;

public class SpellsContentViewModel : ViewModelBase
{
    private readonly ISpellsDataLoader _spellsDataLoader;
    private ObservableCollection<Spell> _spells;
    private Spell _selectedSpell;

    public ObservableCollection<Spell> Spells
    {
        get => _spells;
        set => SetProperty(ref _spells, value);
    }

    public Spell SelectedSpell
    {
        get => _selectedSpell;
        set => SetProperty(ref _selectedSpell, value);
    }

    public SpellsContentViewModel(ISpellsDataLoader spellsDataLoader)
    {
        _spellsDataLoader = spellsDataLoader;
        LoadSpells();
    }

    private void LoadSpells()
    {
        List<Spell> spellsList = _spellsDataLoader.LoadSpells();
        Spells = new ObservableCollection<Spell>(spellsList);
        if (Spells.Any())
        {
            SelectedSpell = Spells.First();
        }
    }
}
