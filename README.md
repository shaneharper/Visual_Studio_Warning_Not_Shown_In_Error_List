## Error List: "Build + IntelliSense" pane does not contain an error shown in the "Build" pane.

The following steps demonstrate a problem with Visual Studio v17.10.5.

* Open the `.sln` file.
* Open `Program.cs`.<br />
    (The problem doesn't occur if Program.cs isn't open in a Visual Studio editor window before it's compiled.)
* Build the solution.<br />
    The following warning will be displayed in the Output window:<br />
        ... `Program.cs(9,17,9,21): warning CS8602: Dereference of a possibly null reference.`
* Check Error List; **The CS8602 warning appears in the "Build" pane" but the warning does not appear in the "Build + IntelliSense" pane!**<br />
    _(If the warning didn't appear in the "Build" pane then select another pane and then go back to the "Build" pane - That problem was reported here: https://developercommunity.visualstudio.com/t/Build-error-missing-from-Error-List/10705983.)_
