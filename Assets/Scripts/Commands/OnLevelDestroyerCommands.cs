using Interfaces;
using UnityEngine;

namespace Commands
{
    public class OnLevelDestroyerCommands : ICommand
    {
        private Transform _levelHolder;


        public OnLevelDestroyerCommands(Transform levelHolder)
        {
            _levelHolder = levelHolder;
        }


        public void Execute()
        {
            Object.Destroy(_levelHolder.GetChild(0).gameObject);
        }

        public void Execute(int value)
        {
        }
    }
}