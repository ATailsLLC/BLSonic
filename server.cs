package BLSonicCommands // This runs the commands for the game.
{
  function serverCmdcredits(%client)
  {
     messageClient(%client, '', "\c6 - Credits -");
     messageClient(%client, '', "\c5 ATails - Coding");
     messageClient(%client, '', "\c6 [Empty Vol. Spot]");
     messageClient(%client, '', "\c6 [Empty Vol. Spot]");
     messageClient(%client, '', "\c6 [Empty Vol. Spot]");
     messageClient(%client, '', "\c6 [Empty Vol. Spot]");
     messageClient(%client, '', "\c6 [Empty Vol. Spot]");
  }
};
activatePackage(BLSonicCommands); // This will automatically parse the package on execution
//Let the Sonic BEGIN!

