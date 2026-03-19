# (C# 3주차 실습과제) 에코 메신저

## 개요
C# 프로그래밍 학습을 위한 에코 메신저 실습 과제입니다.

* **소개**: 사용자 키보드 입력을 받아서 처리하고 화면에 표시하는 메신저 프로그램입니다.
* **사용한 플랫폼**: C#, .NET Windows Forms, Visual Studio, GitHub
* **사용한 컨트롤**: Label, TextBox, ListBox, Button
* **핵심 기술 및 구현 기능**:
  * Visual Studio를 이용한 직관적인 UI 디자인
  * `string` 클래스의 메서드(`Trim`, `IsNullOrWhiteSpace` 등)를 이용한 사용자 입력 데이터 검증 및 처리
  * `DateTime` 클래스를 이용해 현재 시간(타임스탬프) 정보 구하기
  * `ListBox` 컨트롤의 `Items` 속성을 활용한 데이터 누적 및 삭제, 초기화 기능


### 과제1: 기본 UI 및 데이터 연동
- Label, TextBox, Button, ListBox를 배치하고 기본적인 전송 및 입력창 초기화 기능을 구현했습니다.