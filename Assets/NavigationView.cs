using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using SceneTransitionFXProFREE;

public class NavigationView : MonoBehaviour
{
	[SerializeField]
	private	RectTransform			currentView;	
	[SerializeField]
	private	TextMeshProUGUI			textTitle;		
	[SerializeField]
	private	Button					buttonPrev;		
	[SerializeField]
	private	TextMeshProUGUI			textPrevName;
    [SerializeField]
    private TransitionManager transitionManager;

    private	CanvasGroup				canvasGroup;	
	private	Stack<RectTransform>	stackViews;		

	private void Awake()
	{
		canvasGroup	= GetComponent<CanvasGroup>();
		stackViews	= new Stack<RectTransform>();
		
		buttonPrev.onClick.AddListener(Pop);
		SetNavigationBar(currentView.name);
	}

    public void Push(RectTransform newView)
	{
		canvasGroup.blocksRaycasts = false;
	
		RectTransform previousView = currentView;
		previousView.gameObject.SetActive(false);	
		stackViews.Push(previousView);				
		
		currentView = newView;
		currentView.gameObject.SetActive(true);		
		
		canvasGroup.blocksRaycasts = true;
		
		SetNavigationBar(currentView.name, previousView.name);
	}

	public void Pop()
	{
		if ( stackViews.Count < 1 )
		{
			return;
		}

		canvasGroup.blocksRaycasts = false;

		RectTransform previousView = currentView;
		previousView.gameObject.SetActive(false);
		
		currentView = stackViews.Pop();				
		currentView.gameObject.SetActive(true);		
		
		canvasGroup.blocksRaycasts = true;
		
		if ( stackViews.Count > 1 )
		{
			SetNavigationBar(currentView.name, stackViews.Peek().name);
		}
		else
		{
			SetNavigationBar(currentView.name);
		}
	}

	public void SetNavigationBar(string title, string prevBtnName="")
	{
		textTitle.text = title;
		
		if ( prevBtnName.Equals("") )
		{
            //buttonPrev.gameObject.SetActive(true);
            buttonPrev.onClick.AddListener(transitionManager.StartTransition);//홈으로 가기 활성화
        }
		else
		{
            buttonPrev.onClick.RemoveListener(transitionManager.StartTransition);//비활성화
            
            //buttonPrev.gameObject.SetActive(true);
			textPrevName.text = prevBtnName;
		}
	}
}

