using UnityEngine;

namespace Assets.StatSourceSystem
{
    [ExecuteInEditMode]
    public class StatSourceStack : MonoBehaviour
    {
        [SerializeField] private StatSources _sources;
        [SerializeField] private bool _useComponent;
        [SerializeField] private StatSourcesComponent _sourcesComponent;
        [SerializeField] private StatSourceData[] _statSources;

        private void OnEnable()
        {
            if (_useComponent)
            {
                _sourcesComponent.AddStatSource(_statSources);
            }
            else
            {
                _sources.AddStatSource(_statSources);
            }
        }

        private void OnDisable()
        {
            if (_useComponent)
            {
                _sourcesComponent.RemoveStatSource(_statSources);
            }
            else
            {
                _sources.RemoveStatSource(_statSources);
            }
        }
    }
}