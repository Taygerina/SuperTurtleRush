using System.Collections;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [Header("Settings")]
    [SerializeField]
    private float delay = 1f; //TEMPO ENTRE CADA PREFAB QUE VAI SER CRIADO
    [SerializeField]
    private float radius = 5f; //TAMANHO DO RAIO QUE SPAWNA OS OBSTACLES

    [Header("References")]
    [SerializeField]
    private GameObject[] prefabsToSpawn; //VETOR DE PREFABS QUE SERÃO CRIADOS

    private Coroutine _spawnCoroutine = null; //OBJETO QUE GUARDA A ROTINA PARA VERIFICAÇÃO
    private WaitForSeconds _waitForSeconds; //OBJETO QUE ESPERA O TEMPO QUE DEFINIMOS

    private void Start()
    {
        _waitForSeconds = new WaitForSeconds(delay); //CRIA UM WAITFORSECONDS(RESPONSAVEL POR ESPERAR UM TEMPO) E PASSA UM TEMPO(DELAY) QUE ELE VAI ESPERAR
    }

    public void StartRoutine()
    {
        if (_spawnCoroutine != null) //VERIFICA SE A ROTINA ESTÁ ACONTECENDO
        {
            return; //NÃO DEIXA O CÓDIGO ABAIXO EXECUTAR SE O IF FOR VERDADEIRO
        }

        _spawnCoroutine = StartCoroutine(SpawnRoutine()); //INICIA A ROTINA E GUARDAR ELA NA VARIAVEL
    }

    public void StopRoutine()
    {
        if (_spawnCoroutine == null) //SE A ROTINA ESTIVER NULL, SIGNIFICA QUE ELA NÃO ESTÁ ACONTECENDO
        {
            return; //NÃO DEIXA O CÓDIGO ABAIXO EXECUTAR SE O IF FOR VERDADEIRO
        }

        StopCoroutine(_spawnCoroutine); //PARA A ROTINA
        _spawnCoroutine = null; //DEFINE A ROTINA COMO NULL PARA CHECAR SE ELA ESTÁ ACONTECENDO OU NÃO
    }

    private IEnumerator SpawnRoutine() //ROTINA
    {
        while (true) //ACONTECENDO INFINITAMENTE ENQUANTO A ROTINA ESTIVER ATIVA
        {
            yield return _waitForSeconds; //ESPERA UM TEMPO ANTES DE ACONTECER DENOVO O CÓDIGO

            var randomPosition = (Vector2)transform.position + Random.insideUnitCircle * radius; //PEGA UMA POSIÇÃO ALEATORIA DENTRO DO CIRCULO

            var randomPrefab = prefabsToSpawn[Random.Range(0, prefabsToSpawn.Length - 1)]; //PEGA UM PREFAB ALEATORIO DENTRO DO VETOR DE PREFABS

            Instantiate(randomPrefab, randomPosition, Quaternion.identity); //CRIA O PREFAB NA POSIÇÃO ALEATORIA QUE DEFINIMOS E COM A ROTAÇÃO PADRÃO QUE ESTÁ NO PREFAB
        }
    }

    private void OnDrawGizmos() //DESENHA COISAS QUE APARECEM APENAS NO EDITOR E NÃO NO JOGO
    {
        Gizmos.color = Color.red; //DEFINE A COR DO DESENHO
        Gizmos.DrawWireSphere(transform.position, radius); //DESENHA O RAIO DE SPAWN
    }
}
