using Interfaces;
using UnityEngine;

namespace Commands
{
    public class OnLevelLoaderCommands : ICommand
    {
        private Transform _levelHolder;

        public OnLevelLoaderCommands(Transform levelHolder)
        {
            _levelHolder = levelHolder;
        }

        public void Execute()
        {
        }

        public void Execute(int levelID)
        {
            Object.Instantiate(Resources.Load<GameObject>($"Prefabs/LevelPrefabs/level{levelID}"), _levelHolder);
        }
    }
}