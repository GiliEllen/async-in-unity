using System.Threading.Tasks;
using UnityEngine;

public class AsyncDnD : MonoBehaviour
{
    async void Start()
    {
        // task 1:
        Debug.Log("The wizard prepares to attune to Amulet...");
        AttuneToAmulet(); // Async void method
        Debug.Log("The wizard has started the attunement process.");

        // task 2:
        Debug.Log("The wizard begins preparing a powerful spell...");
        await PreparePowerfulSpell();
        Debug.Log("The wizard has completed preparing the spell.");

        // task 5:
         Debug.Log("The wizard embarks on multiple adventures simultaneously...");
        await RunAllAdventures();
        Debug.Log("The wizard's adventures are complete!");
    }

    // task 1 excution:
    private async void AttuneToAmulet()
    {
        Debug.Log("Attuning to the ancient artifact: Amulet...");
        await Task.Delay(2000); // Simulating time taken for attunement
        Debug.Log("The wizard has successfully attuned to Amulet!");
    }

    // task 2 excution:
    private async Task PreparePowerfulSpell()
    {
        Debug.Log("The wizard begins gathering arcane energy...");
        await Task.Delay(1500); // Simulating time to prepare spell
        Debug.Log("The wizard has completed the spell!");
        
        // task 3:
        await CompleteQuest();
    }

    // task 3 excution:
    private async Task CompleteQuest()
    {
        Debug.Log("The wizard embarks on a quest to find the Golden Chalice...");
        await Task.Delay(3000); // Simulating quest time
        Debug.Log("The wizard has found the Golden Chalice!");
        
        // Part 4: Call async void method without waiting for it
        Debug.Log("The wizard begins another attunement to a mysterious relic...");
        AttuneToAmulet();
    }

    // task 5 excution:
    private async Task RunAllAdventures()
    {
        Debug.Log("The wizard embarks on multiple adventures simultaneously...");
        await Task.WhenAll(
            PreparePowerfulSpell(),
            CompleteQuest(),
            AnotherAdventure()
        );
    }

    // task 5 excution more methods:
    private async Task AnotherAdventure()
    {
        Debug.Log("The wizard explores a forgotten dungeon...");
        await Task.Delay(2500); // Simulating dungeon exploration time
        Debug.Log("The wizard has escaped the dungeon with ancient tomes!");
    }
}
