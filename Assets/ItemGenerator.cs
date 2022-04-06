using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour
{
    //carPrefab������
    public GameObject carPrefab;
    //coinPrefab������
    public GameObject coinPrefab;
    //cornPrefab������
    public GameObject conePrefab;
    //�X�^�[�g�n�_
    private int starPos = 80;
    //�S�[���n�_
    private int goalPos = 360;
    //�A�C�e�����o��x�����͈̔�
    private float posRange = 3.4f;
    //Unity�����̃I�u�W�F�N�g
    private GameObject unitychan;
    //Unity������Z���W��ۑ�
    private float position_z = 0f;

    // Start is called before the first frame update
    void Start()
    {
        //Unity�����̃I�u�W�F�N�g���擾
        this.unitychan = GameObject.Find("unitychan");
        
        /* 
                //���̋������ƂɃA�C�e���𐶐�
                for (int i = starPos; i < goalPos; i += 15)
                {
                    //�ǂ̃A�C�e�����o���̂������_���ɐݒ�
                    int num = Random.Range(1, 11);
                    if (num <= 2)
                    {
                        //�R�[����x�������Ɉ꒼���ɐ���
                        for (float j = -1; j <= 1; j += 0.4f)
                        {
                            GameObject cone = Instantiate(conePrefab);
                            cone.transform.position = new Vector3(4 * j, transform.position.y, i);
                        }
                    }
                    else
                    {
                        //���[�����ƂɃA�C�e���𐶐�
                        for (int j = -1; j <= 1; j++)
                        {
                            //�A�C�e���̎�ނ����߂�
                            int item = Random.Range(1, 11);
                            //�A�C�e����u�����W�̃I�t�Z�b�g�������_���ɐݒ�
                            int offsetZ = Random.Range(-5, 6);
                            //60%�R�C���F30%�Ԕz�u�F10%�����Ȃ�
                            if (1 <= item && item <= 6)
                            {
                                //�R�C���𐶐�
                                GameObject coin = Instantiate(coinPrefab);
                                coin.transform.position = new Vector3(posRange * j, coin.transform.position.y, i + offsetZ);
                            }
                            else if (7 <= item && item <= 9)
                            {
                                //�Ԃ𐶐�
                                GameObject car = Instantiate(carPrefab);
                                car.transform.position = new Vector3(posRange * j, car.transform.position.y, i + offsetZ);
                            }
                        }
                    }

                }
                */
    }

    // Update is called once per frame
    void Update()
    {
        //15���[�g�����ƂɃg���K�[������
        if (this.unitychan.transform.position.z - position_z > 15f)
        {
            //�f�o�b�O
            Debug.Log("�g���K�[�F" + this.unitychan.transform.position.z);

            //���̋������ƂɃA�C�e���𐶐�
           // for (int i = starPos; i < goalPos; i += 15)
            //{
                //�ǂ̃A�C�e�����o���̂������_���ɐݒ�
                int num = Random.Range(1, 11);
                if (num <= 2)
                {
                    //�R�[����x�������Ɉ꒼���ɐ���
                    for (float j = -1; j <= 1; j += 0.4f)
                    {
                        GameObject cone = Instantiate(conePrefab);
                        //Unity������40����ɃA�C�e������
                        cone.transform.position = new Vector3(4 * j, transform.position.y, this.unitychan.transform.position.z+40);
                    }
                }
                else
                {
                    //���[�����ƂɃA�C�e���𐶐�
                    for (int j = -1; j <= 1; j++)
                    {
                        //�A�C�e���̎�ނ����߂�
                        int item = Random.Range(1, 11);
                        //�A�C�e����u�����W�̃I�t�Z�b�g�������_���ɐݒ�
                        int offsetZ = Random.Range(-5, 6);
                        //60%�R�C���F30%�Ԕz�u�F10%�����Ȃ�
                        if (1 <= item && item <= 6)
                        {
                            //�R�C���𐶐�
                            GameObject coin = Instantiate(coinPrefab);
                            //Unity������40����ɃA�C�e������
                            coin.transform.position = new Vector3(posRange * j, coin.transform.position.y, this.unitychan.transform.position.z+40 + offsetZ);
                        }
                        else if (7 <= item && item <= 9)
                        {
                            //�Ԃ𐶐�
                            GameObject car = Instantiate(carPrefab);
                        �@�@//Unity������40����ɃA�C�e������
                        �@�@car.transform.position = new Vector3(posRange * j, car.transform.position.y, this.unitychan.transform.position.z+40 + offsetZ);
                        }
                    }
                }

           // }

            //Z���W�̕ۑ��i�X�V�j
            position_z = this.unitychan.transform.position.z;
        }
    }
}
