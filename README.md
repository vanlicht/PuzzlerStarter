# Thomas' Puzzler Project (PuzzlerStarter)
As part of the Udacity VR Nanodegree course, the Puzzler is a mobile VR project that focuses on VR design for comfortable, intuitive viewing experience. In the game, player enters a dungeon structure made of stone bricks. With floating mysterious glowing spheres as puzzle elements, the player is challenged to solve the mystery through memory.

## Unique Considerations
This project explores the design patterns that gives user intuitive, immersive experience, while avoiding / minimizing simulator discomfort.

# Project Title: Puzzler
The basic structure of the puzzle is based on Simon Says structure, in the VR setting of an ancient looking dungeon space in the desert, under the vast starry sky in the night. Without much instruction, users are intrigued by the nightly mesmerizing scenery, and figure out how to solve the puzzle with few try and error, which keeps the game slightly challenging but captivating.


<a href="https://youtu.be/1Q3u3o0X7D8" alt="Puzzler video from Unity3D" target="_blank"><img src="https://github.com/vanlicht/PuzzlerStarter/blob/master/Assets/Documentation/UnityVideoCover.PNG" alt="Puzzler video from Unity3D" width="560">
<br>Puzzler video from Unity3D</a>

<a href="https://youtu.be/F-uN8PfEV5M" alt="Video captured from Android mobile phone " target="_blank"><img src="https://github.com/vanlicht/PuzzlerStarter/blob/master/Assets/Documentation/Puzzler001.png" alt="Puzzler video from Unity3D" width="560">
<br>Video captured from Android mobile phone (the recording has no sound)</a>

# Design Process
## Statement of Purpose
Puzzler is a mobile VR experience for users who are new to VR, to explore the immersive experience and new form of user interaction design in VR.

## Persona
Will, 45 - musician in midwest
“I am curious about new digital experience through new technology.” He is familiar with digital devices such as smartphones and iPads and DSLRs, but is not familiar with mobile games or virtual reality. He prefers to explore experience to be easy to understand, straightforward, and fun. He is novice to VR experience.

## Sketches
Here are some UI sketches and scene layout for conceptualizing the project:

UI design Iteration: Simplify UI, and make the restart panel transparent for user to enjoy the view after successfully solving the puzzle

<img src="https://github.com/vanlicht/PuzzlerStarter/blob/master/Assets/Documentation/sketch001.jpg" alt="First UI design iteration" width="300">

<img src="https://github.com/vanlicht/PuzzlerStarter/blob/master/Assets/Documentation/sketch002.jpg" alt="Second UI design iterationn" width="300">

Scene layout design: Design the scene to make the environment and experience more immersive and appealing

<img src="https://github.com/vanlicht/PuzzlerStarter/blob/master/Assets/Documentation/sketch003.jpg" alt="Scene layout design" width="300">

# User testing
I conducted some user testing on users who has no or few VR viewing experience, in order to test sense of scale, UX and UI design, and alleviation of simulator sickness.

whether the scene scale feels natural; whether user experience is intuitive and easy to follow; whether UI is designed as self-explanatory and intelligible; whether it is comfortable viewing experience.

## First User Test
The first user test was to determine whether the sense of scale of the scene feels natural, and if the scene dressing established the desired mood of mysterious atmosphere in a deserted ancient location. The test result were positive in terms of set dressing, while the overall scale of the main building structure was bit too big, while the exterior props felt small. The next iteration addressed the user testing feedback.

The user who didn’t have much experience wearing google cardboard expressed extreme discomfort when viewing the experience through the cardboard. When I put the phone into Daydream View headset, the user commented that the view was much more natural, in focus, and comfortable.  The other user who was more familiar with the cardboard was able to adjust the viewing angle to comfortably view the puzzler experience.

## Second User Test
The second user test focuses on the mechanism of interactivity, to see whether user determines the intuitiveness of the experience, and whether the UI design provides comprehensible feedback. The user expressed positively of the visual feedback during different states of behaviour -- the button gives clear feedback of color changes when it’s not selected versus when gazed versus when selected. The users also expressed liking the audio ambience change between exterior and interior environment in the VR application. 

The text description on the start and restart panel give minimal yet helpful and clear guidance. In the game there’s no additional textual description regarding the puzzles. Some user was able to grasp the pattern right away, while some others were initially confused. It’s debatable whether to put more description of how to play the game. Ultimately I decided to leave the description off, considering that this is a small, straightforward experience and users tends to get extra satisfaction once they figure out the pattern of how to solve the puzzle. It the scope of the experience is more grandeur and bigger, then I would put more description in along the way.

## Third User Test
The third and final user testing focused on the speed of movement, UI fine tuning and placement, and lighting of the environment. The user responded positively about the change of the Restart UI panel to transparent, so they could look beyond and see the scenery of wilderness and starry night sky, which provided additional stereoscopic effectiveness/ sense of depth between the UI and the background. The user also was amazed by the the night scene and the milky way starry night sky. The torches in the dungeon  reinforced the mysterious ambience. The user found the glowing orbs accompanying sound provided good visual and audio que. For the traveling speed, the users felt it was right amount of speed that was comfortable for them while also able to enjoy the view without feeling dizzy.

# Breakdown of the final piece
The final result of the experience is documented in the following screen captured directly from the android phone app. At the start (picture 1), the users sees a Start UI panel with a button for them to click, while the environment also provides interesting and immersive experience for them to look around prior to starting the game (picture 2 and 3). After clicking the on the start button, the user is moved to the ancient looking structure where the interior is illuminated by the torch (picture 4 and 5). Inside the building, there are 5 orbs that illuminate in random sequence of five that the user has to remember (picture 6). If the attempt of re-creating the sequence is wrong, the alert sounds, and the orbs will illuminate the same pattern again for the use to try. If successful, the user exits the dungeon back to the exterior desert night scene (picture 7 through 10). The user can restart the game by clicking on the Restart button.

<img src="https://github.com/vanlicht/PuzzlerStarter/blob/master/Assets/Documentation/Puzzler001.png" alt="Scene layout design" width="300">
<img src="https://github.com/vanlicht/PuzzlerStarter/blob/master/Assets/Documentation/UnityVideoCover.PNG" alt="Puzzler video from Unity3D" width="560">
<br>Puzzler video from Unity3D</br>


<img src="https://github.com/vanlicht/PuzzlerStarter/blob/master/Assets/Documentation/Puzzler002.png" alt="Scene layout design"
width="300">
<img src="https://github.com/vanlicht/PuzzlerStarter/blob/master/Assets/Documentation/Puzzler003.png" alt="Scene layout design"
width="300">
<img src="https://github.com/vanlicht/PuzzlerStarter/blob/master/Assets/Documentation/Puzzler004.png" alt="Scene layout design"
width="300">
<img src="https://github.com/vanlicht/PuzzlerStarter/blob/master/Assets/Documentation/Puzzler005.png" alt="Scene layout design"
width="300">
<img src="https://github.com/vanlicht/PuzzlerStarter/blob/master/Assets/Documentation/Puzzler006.png" alt="Scene layout design"
width="300">
<img src="https://github.com/vanlicht/PuzzlerStarter/blob/master/Assets/Documentation/Puzzler007.png" alt="Scene layout design"
width="300">
<img src="https://github.com/vanlicht/PuzzlerStarter/blob/master/Assets/Documentation/Puzzler008.png" alt="Scene layout design"
width="300">
<img src="https://github.com/vanlicht/PuzzlerStarter/blob/master/Assets/Documentation/Puzzler009.png" alt="Scene layout design"
width="300">
<img src="https://github.com/vanlicht/PuzzlerStarter/blob/master/Assets/Documentation/Puzzler010.png" alt="Scene layout design"
width="300">
