using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloCode : MonoBehaviour 
{
    void Start()
    {
        // Hello World!를 콘솔에 출력
        Debug.Log("Hello World!");

        // 캐릭터의 프로필을 변수로 만들기
        string characterName = "라라";
        char bloodType = 'A';
        int age_ = 17;
        float height_ = 168.3f;
        bool isFemale = true;

        // 생성한 변수를 콘솔에 출력
        Debug.Log("캐릭터 이름 : " + characterName);
        Debug.Log("혈액형 : " + bloodType);
        Debug.Log("나이 : " + age_);
        Debug.Log("키 : " + height_);
        Debug.Log("여성인가? : " + isFemale);

        // 두 점 사이의 거리 계산
        float distance = GetDistance(2, 2, 5, 6);
        Debug.Log("(2,2)에서 (5,6)까지의 거리 : " + distance);

        // 호감도에 따른 엔딩 구현
        int love = 80;
        if (love>90)
        {
            Debug.Log("트루엔딩: 히로인과 결혼했다!");
        }
        else if (love>70)
        {
            Debug.Log("굿엔딩: 히로인과 사귀게 되었다!");
        }
        else
        {
            Debug.Log("배드엔딩: 히로인에게 차였다.");
        }

        // 논리연산자
        int age = 11;

        if (age>7 && age<18)
        {
            Debug.Log("의무 교육을 받고 있습니다.");
        }

        if (age<13 || age>70)
        {
            Debug.Log("일을 할 수 없는 나이입니다.");
        }

        // 반복문
        for(int i=0 ; i<10 ; i++)
        {
            Debug.Log(i+" 번째 순번입니다.");
        }

        int j = 0;

        while(j<10)
        {
            Debug.Log(j+" 번째 루프입니다.");
            j++;
        }

        // 배열을 사용해 점수 관리하기
        int[] students = new int[5];

        students[0] = 100;
        students[1] = 90;
        students[2] = 80;
        students[3] = 70;
        students[4] = 60;

        for (int x=0; x<students.Length; x++)
        {
            Debug.Log((x+1)+" 번 학생의 점수 : "+students[x]);
        }
     }

    float GetDistance(float x1, float y1, float x2, float y2)
    {
        float width = x2 - x1;
        float height = y2 - y1;

        float distance = width * width + height * height;
        distance = Mathf.Sqrt(distance);

        return distance;
    }
        
}