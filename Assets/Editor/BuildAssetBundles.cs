using System.IO;
using UnityEditor;
using UnityEngine;

namespace Editor
{
    public class BuildAssetBundles : MonoBehaviour
    {
        private const string BuildMenuPath = "Assets/Build TOU-Mira Bundles";

        private const string BuildDirectory = "AssetBundles";

        private const string AssetFolder = "Assets/TOU-Mira";

        [MenuItem(BuildMenuPath)]
        public static void BuildFromSelectedFolder()
        {
            if (!AssetDatabase.IsValidFolder(AssetFolder))
            {
                Debug.LogError("The selected item is not a folder. Please select a folder.");
                return;
            }

            Debug.Log("Starting TOU asset bundle build...");

            BuildBundle("tou-assets-windows.bundle", BuildTarget.StandaloneWindows);

            Debug.Log("Finished building WINDOWS asset bundle. Starting ANDROID build...");

            BuildBundle("tou-assets-android.bundle", BuildTarget.Android);

            Debug.Log("Finished building ANDROID asset bundle.");

            Debug.Log("Asset bundles are located in the AssetBundles folder in the project root.");
        }

        private static void BuildBundle(string name, BuildTarget buildTarget)
        {
            var assetPaths = Directory.GetFiles(AssetFolder, "*", SearchOption.AllDirectories);

            var builds = new AssetBundleBuild[1];
            builds[0].assetBundleName = name;
            builds[0].assetNames = assetPaths;
        
            if (!Directory.Exists(BuildDirectory))
            {
                Directory.CreateDirectory(BuildDirectory);
            }

            BuildPipeline.BuildAssetBundles(BuildDirectory, builds, BuildAssetBundleOptions.None, buildTarget);
        }
    }
}
