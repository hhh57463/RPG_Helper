# RPG Helper
-----
RPG를 만들 때 필요한 기능들을 구현해놓은 프로젝트

## Monster_AI
-----
몬스터의 이동 방법을 구현해 놓은 씬
### 몬스터 종류
+ 범위내 몬스터: 스폰 지역 내에서 이동하거나 멈춰있는 몬스터
![image](Readme/Monster_1.gif)
+ 범위내 추적 몬스터: 스폰 지역 내에 플레이어를 추적하는 몬스터
![image](Readme/Monster_2.gif)
+ 추적 몬스터: 자신의 추적 범위 내에 플레이어를 추적하는 몬스터
![image](Readme/Monster_3.gif)

## NPC
-----
NPC와 대화하는 대화창을 구현해 놓은 씬
### 대화 범위
대화를 하기 위해서는 범위 내에 있어야함 NPC에게 두개의 collider를 넣어 isTrigger를 false로 지정하였음<br>
대화중에 움직임은 불가능하며 카메라의 대상이 해당 NPC로 변경
![image](Readme/NPC_Dialog.gif)

## Skill
-----
직업 별로 스킬을 다르게 구현할 수 있게 만들어 놓은 씬
### SceneMng
SceneMng_Skill이 들어가 있는 오브젝트에서 직업을 선택하면 해당 직업에 맞는 캐릭터 생성<br>
1,2,3,4,5 키를 눌러 스킬 사용 가능 (현재 로그만 출력)

## Level
-----
캐릭터의 레벨 시스템을 구현해 놓은 씬
### LevelMng
LevelData.json에 레벨과 레벨업에 필요한 경험치를 저장하여 읽어옴<br>
현재 1~10레벨 까지 있으며 수정 가능<br>
씬에 존재하는 버튼은 1레벨 업 기능과, 1,5,10의 경험치를 주는 버튼으로 구성

## Demo
-----
현재 구현해놓은 기능들을 합쳐 놓은 씬


<br><br><br>
### 추가 설치 패키지
-----
Cinemachine, TextMeshPro