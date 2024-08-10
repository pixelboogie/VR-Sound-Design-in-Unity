# VR-Sound-Design-in-Unity

## Description
**VR-Sound-Design-in-Unity** is a project focused on creating immersive audio experiences in a VR environment. The project allows users to play virtual drums, with sound effects that vary based on the player's interactions, such as the speed of the drumstick. This project was built using Unity and C#, and it is based on the video tutorial "VR Sound Design in Unity" by Valem Tutorials, which can be found [VR Sound Design in Unity](https://www.youtube.com/watch?v=sCObQSNRqN4).

## Features
- **Interactive Virtual Drums**: Users can play virtual drums in a VR environment, with sound triggered by hitting the drum surfaces.
- **Audio Loudness Detection**: The volume and pitch of the sounds vary based on the speed and intensity of the player's interactions.
- **3D Sound**: The project implements 3D sound to make it feel like the audio is coming from specific locations within the scene, enhancing the immersive experience.
- **Pitch Randomization**: Adds realism by randomizing the pitch of the drum sounds, making each hit sound slightly different.

## Installation
To set up this project locally, follow these steps:

1. **Clone the Repository:**
   ```bash
   git clone https://github.com/your-username/VR-Sound-Design-in-Unity.git

   cd VR-Sound-Design-in-Unity

2. **Open in Unity:**

    - Open the project folder in Unity.
    - Ensure that you have the required Unity version installed that supports the scripts and features used in this project.

3. **Set Up the Scene:**

    - Follow the steps provided in the video tutorial to set up the necessary GameObjects, such as the drumsticks and drum surfaces, and assign the scripts to the appropriate objects.

4. **Run the Project:**

    - Once the setup is complete, you can run the project in Unity to experience the interactive sound design in VR.

## Example Code

Here is a snippet from the script that handles the audio triggering when the drum surfaces are hit:

    public class PlayAudioOnTriggerEnter : MonoBehaviour {
        public AudioClip clip;
        private AudioSource source;
        public string targetTag = "DrumStick";

        void Start() {
            source = GetComponent<AudioSource>();
        }

        void OnTriggerEnter(Collider other) {
            if (other.CompareTag(targetTag)) {
                source.PlayOneShot(clip);
            }
        }
    }

This script triggers an audio clip when the drumstick collides with a drum surface, adding a layer of interactivity to the VR environment.

## Video Tutorial
This project is based on the video tutorial by Valem Tutorials, which can be found here: [VR Sound Design in Unity](https://www.youtube.com/watch?v=sCObQSNRqN4).

## License
This project is licensed under the MIT License. See the LICENSE file for more information.
