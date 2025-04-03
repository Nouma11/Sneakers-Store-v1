Sneakers Store v1

📌 Overview

Sneakers Store v1 is a Windows Forms application built with C#. It provides an interactive way to explore different sneaker models from popular brands using a tree-view interface. When a sneaker model is selected, its price and image are displayed dynamically.

🚀 Features

🗂️ Tree View Navigation:

Select a sneaker brand from treeView1 to view available models in treeView2.

📷 Image & Price Display:

Selecting a model fetches its image and price from Modeles.txt.

📁 Data Management:

Sneaker data is stored in a structured text file (Modeles.txt).

🛠️ Technologies Used

Language: C#

Framework: .NET Framework (Windows Forms)

File Handling: Reads and processes data from Modeles.txt

🏗️ Installation

Clone the repository:

git clone https://github.com/your-username/sneakers-store-v1.git

Open the project in Visual Studio.

Ensure Modeles.txt is available at:

C:\Users\Med Amine\source\Window Form\Sneakers Store\Modeles.txt

Run the project using Visual Studio.

📂 File Structure

Sneakers Store v1/
│-- Form1.cs                # Main form logic
│-- Form1.Designer.cs       # UI components
│-- Program.cs              # Application entry point
│-- Modeles.txt             # Sneaker data file (Model#Price#ImagePath)
│-- SneakersStore.sln       # Solution file

📜 Data File Format (Modeles.txt)

Each line in Modeles.txt follows this format:

Model Name#Price#Image Path

Example:

Air Jordan 1#150$#C:\Images\AirJordan1.jpg
Nike Air Force 1#120$#C:\Images\NikeAF1.jpg

🤝 Contributing

Fork the repository.

Create a new branch (feature-branch).

Commit your changes (git commit -m "Added new feature").

Push to the branch (git push origin feature-branch).

Open a Pull Request.

📜 License

This project is licensed under the MIT License.
