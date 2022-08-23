using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.AddressableAssets;

public class AddressableLoader : MonoBehaviour
{
    private SampleData _sample;
    private PlayerHandler _player;
    
    public AssetReferenceT<SampleData> sampleData;

    public AssetReference player;
    // Start is called before the first frame update
    void Start()
    {
        sampleData.LoadAssetAsync().Completed += handler =>
        {
            _sample = handler.Result;
            Debug.LogError(_sample.Sprites.Count);
        };

        player.InstantiateAsync(Vector3.zero, quaternion.identity).Completed += handler =>
        {
            _player = handler.Result.GetComponent<PlayerHandler>();
        };
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
