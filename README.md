# Flappy_Bird
I learned how to create Flappy Bird on Unity to learn how to create an endless level and how to implement a scoring system with a high score. For each step, I attempted to implement the step before watching the video to check my understanding of Unity and C#.

## Steps
1. I found [this tutorial](https://www.youtube.com/watch?v=hKGzSYXPQwY) to make this game. I started by downloading the sprite sheet and set up the camera and background. I then added the bird and gave it a movement script to allow it to fly when space was pressed. This was fairly similar to my [2D platformer](https://github.com/shreyaorange28/My_First_2D_Platformer_Unity) so I was able to complete most of these steps without watching the video. 
2. The next step was to add pipes that move to the left and then create a script allowing them to autogenerate. For this step, I did not know how to spawn prefabs so I had to use the tutorial entirely.
3. I added the game over canvas and made it stop the game when the bird collided with the ground or the pipes. I was able to complete this step before watching the tutorial using my experience with the OnCollisionEnter2D methods during the creation of my [2D platformer](https://github.com/shreyaorange28/My_First_2D_Platformer_Unity). 
4. Finally, I added the scoring system. It incremented the score when the bird sprite collided with a box collider between the pipes and automatically updated the high score. This step was a little more difficult as when I attempted to write the script before watching the tutorial script, I accidentally used the wrong method for the box collider between the pipes but in the process of debugging, I learned how to debug in Unity and print updates and variables to the console and figured it out.

## Video

<video src="https://github.com/user-attachments/assets/6477a1d4-976b-47c9-8001-267536fdd7c3"></video>


## Next Steps
In the future, I'd like to learn how to publish Flappy Bird onto the Unity store or a react website. I'd also like to add additional features like changing the character, adding different types of obstacles, or adding powerups. 
