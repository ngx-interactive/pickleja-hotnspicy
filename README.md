
# Unity Template Repository

Welcome to the Unity Template Repository! This template is designed to kickstart your Unity projects with a collection of essential packages and tools that will streamline your development process.

## 📦 Included Packages:

1. **TextMeshPro** - An advanced text rendering solution which provides superior flexibility and performance when compared to traditional GUI Text and Text Mesh.
2. **DOTween** - A fast, efficient, fully type-safe object-oriented animation engine for Unity.
3. **LeanTouch** - A versatile input system that works with touch, multi-touch, mouse, and more.
4. **Mathf** - A collection of common math functions and utilities to make your Unity scripting tasks easier.
5. **EasyButtons** - Simplify your editor scripting by adding buttons to your inspector.
6. **Addressables** - A new way to handle asset data in Unity, providing an easy way to load assets by “address”.
7. **Unity Localization** - A package that provides a way to localize an application or game in multiple languages.

## 🚀 Getting Started:

1. **Use this Template**:
click on "create a new repository"
![Screenshot (113)](https://github.com/JediMonkeyDan/Unity-Template/assets/109318052/f3225370-3af8-4b6b-9fa4-6713820046c5)


2. **Owner/ Repository name**:
Use the Owner dropdown menu to select the account you want to own the repository. 
Type a name for your repository, and an optional description.
![Screenshot (114)](https://github.com/JediMonkeyDan/Unity-Template/assets/109318052/816c4ddb-111c-4cea-9ac6-40e2615902b2)



3. Click Create repository from template.


## 🛠 Usage:

1. TextMeshPro: Navigate to GameObject > UI > Text - TextMeshPro to create a new TextMeshPro object.
2. DOTween: Access DOTween through scripts using DG.Tweening namespace.
3. LeanTouch: Check the LeanTouch component in the inspector for touch-based functionalities.
4. Mathf: Utilize the Mathf class in your scripts for mathematical operations.
5. EasyButtons: Decorate your methods with [Button] attribute to create a button in the inspector.
6. Addressables: Use the Addressables window (Window > Asset Management > Addressables) to manage your assets.
7. Unity Localization: Navigate to Window > TextMeshPro > Localization to manage and add new languages.

## ☁️ Cloud Build:

This template comes equipped with a `.github/workflows` directory containing a `main.yaml` file. With this setup, GameCI is configured to automatically generate a Windows executable build from the repository. This build process is triggered as soon as any push commit is made to the `main` and `QA` branch. This ensures that you always have an up-to-date build ready for testing and deployment, streamlining your development and QA processes. To learn more about how this process works behind the scene, visit the DevOps notion page https://www.notion.so/ngxinteractive/CI-CD-GAME-CI-workflow-e00174c7a99c4d859192dd75abcfaa4b
