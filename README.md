# **The Pine Forest**

Final Project for Udacity VRND
Video Link: [Video Submission](https://www.dropbox.com/s/xljemyipd7vlc0c/final_movie.mp4?dl=1)

# **Capstone Planning Document**

## Description
For my Capstone Project, I will be building an interactive tour experience for the Google Cardboard. The subject is the Pine Forest of the city of Guardamar, in the south east coast of Spain, which is a great example of reforestation and ecological sustainability in the  relation between a city and the nature around.
Besides the explanations and pictures of the reforestation process, the main idea is to build 2 scenes in Unity, to describe the state of the city before and after the operation. Using a navigation system, users will be able to walk around in both situations, experiencing the differences and hopefully developing an awareness for a more armonic relation between humans and nature.
## Structure
The experience will start with a welcome panel. It will have welcome text describing the experience, and some navigation buttons to start/restart the tour. At least, user can choose to visit the landscape before the reforestation, and in present state. Maybe, if possible include a third scene ‘during the works’. Inside each scene, user can move freely/waypoints to visit some interesting places: in the first scene the sand on the beach, the semiburied village. In the second scene, the works, the small plants, wood fence, trees nurseries, wells, mules and workers and in the third the actual forest, and the modern city. In these points, panels or narration (audio sources) can describe moments of the process.
## Features and Dependencies
### 3D Models and Animations

 - Natural landscape with mountains of sand, beach and sea. (DOABLE, asset store)
 - Simple village (DOABLE, USING BLENDER)
 - Pine trees and forest. (DOABLE, asset store)
 - Modern buildings. (REMOVED)
 - Animals and other complements. (DOABLE, asset store)

### Game Loop

 - Welcome panel buttons to start each scene (DOABLE: controls to controls to move through waypoints and play/stop audio narration)
 - Waypoints to move in the scene (DOABLE)
 - Video Player (DOABLE)
 - Visibility toggle of relevant elements for narration on each scene (DOABLE)
### Other Effects
 - Particle system for wind/sand (REMOVED)
 - Directional Sound Effects (DOABLE, on animals)
 - Sound effects for wind, sea (DOABLE: wind sound effect.)
 - Wind effect for trees (REMOVED)

## **Achievements**
### Fundamentals (600pts)

 - Scale (100pts): User feels human size related to landscape and houses. Scale disparity is achieved using small trees vs big trees.
 - Light (100pts): Moving elements have realtime light (horses, seaguls), static elements use baked.
 - Locomotion (100pts): A system of waypoints allows user to move through the scene.
 - Video Player (200pts, because Light is also achieved): There is a video player on narration 1.
 - Empathy (100pts):  The project aims to raise ecologycal awareness and love for nature, describing the creation of an ecosystem in which humans and nature coexist for mutual benefit.
### Completedness (750pts)
 - Diegetic UI (250pts): The only text is the title on the first panel. All other interaction elements use universal graphic symbols.
 - Alternative Storytelling (250pts): Not only users can navigate backwards from each station, they also can go directly to each station from the start panel.
 - 3D Modeling (250pts): All the houses are done by me, using Blender.
### Challenges (500pts)
 - User testing (500pts, because of 750pts in Completedness): I performed 2 user tests, see results below.
## **Test Results**
 - Test 1: User feels the appropriate size, related to all elements of the environment (landscape, houses, small and big trees). The narrative flow is clear, gui elements are the right size, easy to interact with and visible without getting in the way. Transition speed between waypoints is also appropriate. The sound of the wind is too loud, not only during narrations but in general. This makes it difficult to listen to the narrations on each station, and is the only discomfort experienced by the tester. 
 - Test 2: After adjustments to audio levels of narration and ambient sound, user says the experience is more comfortable, she can listen very well to the narration while the ambient sound provides an immersive sensation. After adding models for animals (horses and seaguls), everything feels more ‘realistic’. User has a positive opinion of the whole experience.
## **Narrations Text**
 - *Narration Start*: Welcome to The Pine Forest VR project. You are about to enter an immersive experience to learn more about The Pine Forest in the town of Guardamar, in the South East coast of Spain. This is a mediterranean forest you can enjoy today that is an essential part of the town’s landscape and history. Let’s begin!
 - *Narration 1:* One hundred years ago the town of Guardamar looked like this. At the end of the 19th century it was just a small fishermen's village. The beach was full of immense dunes, with very little vegetation. Because of that, the winds and storms moved the dunes in an unpredictable way, to the point that many houses became buried in sand in several ocasions. After a petition for help to the Government, which sent engineers Ricardo Codorniu and Francisco Mira, they came up with a plan: to build two natural barriers, an artificial dune and a forest of pines that would prevent the sand to bury the houses again.
 - *Narration 2:* The engineers and the people of Guardamar worked on the project for 30 years. First, a fence of wood and cane was put in place at the beach, a few meters away from the water. After the sand covered the top of the barrier every year, it’s height was increased. This stage lasted 4 years, and created an artificial dune 3 meters high to slow down the winds. This artificial dune still exists and can be seen today at the beach.
 - *Narration 3:* During the second phase, since there was nothing but sand, everything had to be created: several houses as refugee for the workers, the nursery to grow the pines from seeds, the wells to get the water, even the paths to allow transportation of items and workers. The first years presented many difficulties, including several plagues of locust that destroyed part of the plantations of young pine trees.
 - *Narration 4:* 30 years after the beginning of the work, the king Alfonso XII visited the city to celebrate the success of the project. The pines had grown enough to defend themselves and the village was now safe from the winds and the sand. During the 50’s and 60’s the first tourists arrived, appreciating the rich ecosystem created around the pine forest. These days the forest and the beaches drive the town’s economy making Guardamar a unique tourist destination for thousands of people every year.

Pedro Gonzalez Ferrandez. 
Madrid, May 2018
