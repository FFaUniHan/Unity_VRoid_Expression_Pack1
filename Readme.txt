Thank you for purchasing this pack! Open this in Unity Hub using Unity 2021.2 and open up the scene file!

You don't need to use every scripts in this project. Most of the expressions are animation clips, so you can easily copy or export it to your project. However, you will need the script for swapping textures for the 



This project uses 6 scripts:
- UIExpressionControl.cs is used in the UI Button to trigger a new expression animation and to create particle effects. All of it is triggered by a function called in the Button UI Event.

- ExpressionManager.cs is used for swapping face and eye textures. 

- SwapTextureExtra.cs and SwapTextureEye.cs are State Machine Behavior scripts that can only be placed inside an animator state. They are used to call a swap texture function in ExpressionManager.cs, because you can't do a texture swap inside a State Machine Behavior script.

- UIButtonArrange.cs and UIButtonInOne.cs are for button UI placement. This helps me auto-arrange the grid for the UI buttons. This is not essential, so you don't need it for the expressions.