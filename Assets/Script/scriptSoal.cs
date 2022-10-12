using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scriptSoal : MonoBehaviour
{
    // public GameObject soal_live, soal_lanjut;
    public string jawaban;
    public Text info, jawab;
    // Start is called before the first frame update
    void Start()
    {
        // soal_live.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   

    public void cek(){
        if(jawab.text == jawaban){
            info.text = "HEBATT";
            // soal_live.SetActive (false);
            // soal_lanjut.SetActive (true);

        }else{
            info.text = "BELAJAR LAGI DEK !";
        }
    }
}
